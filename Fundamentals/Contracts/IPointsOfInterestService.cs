using System.Collections.Generic;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IPointsOfInterestService
    {
        [OperationContract]
        IEnumerable<PointOfInterest> GetPointsOfInterestForState(string state);
    }

    public class PointsOfInterestService : IPointsOfInterestService
    {
        public IEnumerable<PointOfInterest> GetPointsOfInterestForState(string state)
        {
            switch (state)
            {
                case "Kerala":
                    return new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Sri Padmanabha Temple",
                            Description = "The richest temple"
                        },
                        new PointOfInterest
                        {
                            Name = "Kovalam",
                            Description = "The beautiful beach"
                        }
                    };
                case "Karnataka":
                    return new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Lal Bag",
                            Description = "The botanical garden"
                        },
                        new PointOfInterest
                        {
                            Name = "Brindavan Garden",
                            Description = "The big big gaden"
                        }
                    };
                default:
                    return new List<PointOfInterest>();
            }
        }
    }
}