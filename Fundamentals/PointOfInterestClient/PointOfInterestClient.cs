using System.Collections.Generic;
using System.ServiceModel;
using Contracts;

namespace PointOfInterestClient
{
    public class PointOfInterestClient : ClientBase<IPointsOfInterestService>, IPointsOfInterestService
    {
        public IEnumerable<PointOfInterest> GetPointsOfInterestForState(string state)
        {
            return Channel.GetPointsOfInterestForState(state);
        }
    }
}