using System;
using System.Collections.Generic;
using System.Linq;
using QSP.RouteFinding.Containers;
using QSP.RouteFinding.Tracks.Pacots;
using QSP.RouteFinding.Tracks.Interaction;
using static QSP.RouteFinding.Containers.TrackedWptList;
using static QSP.MathTools.MathTools;

namespace QSP.RouteFinding.Tracks.Common
{

    public abstract class TrackHandler
    {
        protected List<ITrack> allTracks;
        protected TrackedWptList wptList;

        public abstract void GetAllTracks();
        public abstract void GetAllTracksAsync();
        protected abstract string airwayIdent(ITrack trk);

        public TrackHandler() : this(RouteFindingCore.WptList)
        {
        }
        
        public TrackHandler(TrackedWptList WptList)
        {
            allTracks = new List<ITrack>();
            this.wptList = WptList;
        }
        
        public void AddToWptList()
        {
            if (allTracks.Count > 0)
            {
                if (allTracks.First() is PacificTrack)
                {
                    wptList.DisablePacots();
                    wptList.TrackChanges = TrackChangesOption.AddingPacots;
                }
                else
                {
                    wptList.DisableAusots();
                    wptList.TrackChanges = TrackChangesOption.AddingAusots;
                }
                
                foreach (var i in allTracks)
                {
                    addTrackToWptList(i);
                }

                wptList.TrackChanges = TrackedWptList.TrackChangesOption.No;
            }
        }
        
        private void addTrackToWptList(ITrack item)
        {
            TrackReader reader = null;
            
            try
            {
                reader = new TrackReader(item);
                addMainRoute(reader.MainRoute, item);
            }
            catch 
            {
                RouteFindingCore.TrackStatusRecorder.AddEntry(StatusRecorder.Severity.Caution, "Failed to process track " + 
                                                              item.Ident + ".", (item is PacificTrack) ? TrackType.Pacots : TrackType.Ausots);
            }

            if (reader != null)
            {
                foreach (var i in reader.PairsToAdd)
                {
                    addPairs(i);
                }
            }
        }

        private void addPairs(WptPair item)
        {
            wptList.AddNeighbor(item.IndexFrom, new Neighbor(item.IndexTo, "DCT", wptList.Distance(item.IndexFrom, item.IndexTo)));
        }


        private void addMainRoute(Route rte, ITrack trk)
        {
            int indexStart = addFirstWpt(rte.Waypoints.First());
            int indexEnd = addLastWpt(rte.Waypoints.Last());

            wptList.AddNeighbor(indexStart, new Neighbor(indexEnd, airwayIdent(trk), TotalDis(rte)));
        }

        //returns the index of added wpt in wptList
        private int addFirstWpt(Waypoint wpt)
        {
            int x = wptList.FindByWaypoint(wpt);
            
            if (x >= 0)
            {
                if (wptList.NumberOfNodeFrom(x) == 0)
                {
                    //no other wpt have this wpt as a neighbor, need to find nearby wpt to connect

                    List<int> k = Utilities.NearbyWaypointsInWptList(20, wpt.Lat, wpt.Lon);

                    foreach (var m in k)
                    {
                        wptList.AddNeighbor(m, new Neighbor(x, "DCT", wptList.Distance(x, m)));
                    }
                }
                return x;
            }
            throw new TrackWaypointNotFoundException(string.Format("Waypoint {0} is not found.", wpt.ID));
        }

        private int addLastWpt(Waypoint wpt)
        {
            int x = wptList.FindByWaypoint(wpt);

            if (x >= 0)
            {

                if (wptList.ElementAt(x).Neighbors.Count == 0)
                {
                    List<int> k = Utilities.NearbyWaypointsInWptList(20, wpt.Lat, wpt.Lon);

                    foreach (var m in k)
                    {
                        wptList.AddNeighbor(x, new Neighbor(m, "DCT", wptList.Distance(x, m)));
                    }
                }
                return x;
            }
            throw new TrackWaypointNotFoundException(string.Format("Waypoint {0} is not found.", wpt.ID));
        }

        private static double TotalDis(Route route)
        {
            var wpts = route.Waypoints;

            if (wpts.Count <= 1)
            {
                return 0;
            }

            double dis = 0;

            for (int i = 0; i <= wpts.Count - 2; i++)
            {
                dis += GreatCircleDistance(wpts[i].Lat, wpts[i].Lon, wpts[i + 1].Lat, wpts[i + 1].Lon);
            }

            return dis;
        }

    }

}
