﻿using System.Linq;
using System.Threading.Tasks;
using NFluent;
using NSubstitute;
using TechTalk.SpecFlow;


namespace TrainTrain.Spec.StepDefinitions
{
    [Binding]
    public class TrainTrainReservationSteps
    {

        [Given(@"the train ""(.*)""")]
        public void GivenTheTrain(string trainId)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"(.*) coaches of (.*) seats available")]
        public void GivenTheTrainContainsCoachesOfSeatsAvailables(int coachCount, int seatsCount)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"(.*) seats are requested")]
        public void WhenSeatsRequested(int seatsRequestedCount)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"(.*) coaches of (.*) seats and (.*) already reserved")]
        public void GivenCoachesOfSeatsWithAlreadyReserved(int coachesCount, int availableSeatsCount,
            int seatsReservedCount)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"(.*) coaches of (.*) seats and (.*) seats already reserved in the coach (.*)")]
        public void GivenCoachesOfSeatsWithSeatsAlreadyReservedInTheCoach(int coachesCount, int availableSeatsCount, int seatsReservedCount, int coachNumberWhereReserved)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the reservation (.*) should be assigned these seats ""(.*)""")]
        public void ThenTheReservationShouldReserveSeats(string bookingReference, string expectedSeats)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the reservation (.*) should be failed")]
        public void ThenTheReservationShouldFail(string bookingReference)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the reservation (.*) should be assigned these seats ""(.*)"" in the same coach")]
        public void ThenTheReservationBcdShouldReserveInSameCoach(string bookingReference, string expectedSeats)
        {
            ScenarioContext.Current.Pending();
        }
    }
}