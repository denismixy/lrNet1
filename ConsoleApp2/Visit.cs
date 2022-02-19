using System;
using System.Collections.Generic;
using System.Text;

namespace lrNet1 {
    class Visit {
        private Client client;
        private string startParkingDate;
        private string endParkingDate;
        private string parkingPlace;
        private string cost;

        public Visit() {
        }

        public Visit(Client client, string startParkingDate, string endParkingDate, string parkingPlace, string cost) {
            this.client = client;
            this.startParkingDate = startParkingDate;
            this.endParkingDate = endParkingDate;
            this.parkingPlace = parkingPlace;
            this.cost = cost;
            
        }

        public string StartParkingDate { get => startParkingDate; set => startParkingDate = value; }
        public string EndParkingDate { get => endParkingDate; set => endParkingDate = value; }
        public string ParkingPlace { get => parkingPlace; set => parkingPlace = value; }
        public string Cost { get => cost; set => cost = value; }
        internal Client Client { get => client; set => client = value; }

        public override bool Equals(object obj) {
            return obj is Visit visit &&
                   EqualityComparer<Client>.Default.Equals(client, visit.client) &&
                   startParkingDate == visit.startParkingDate &&
                   endParkingDate == visit.endParkingDate &&
                   parkingPlace == visit.parkingPlace &&
                   cost == visit.cost &&
                   StartParkingDate == visit.StartParkingDate &&
                   EndParkingDate == visit.EndParkingDate &&
                   ParkingPlace == visit.ParkingPlace &&
                   Cost == visit.Cost &&
                   EqualityComparer<Client>.Default.Equals(Client, visit.Client);
        }

        public override int GetHashCode() {
            HashCode hash = new HashCode();
            hash.Add(client);
            hash.Add(startParkingDate);
            hash.Add(endParkingDate);
            hash.Add(parkingPlace);
            hash.Add(cost);
            hash.Add(StartParkingDate);
            hash.Add(EndParkingDate);
            hash.Add(ParkingPlace);
            hash.Add(Cost);
            hash.Add(Client);
            return hash.ToHashCode();
        }
    }
}
