using System;
using System.Collections.Generic;
using System.Text;

namespace lrNet1 {
    class Visit {
        private string fio;
        private string carBrand;
        private string carNumber;
        private string carModel;
        private string startParkingDate;
        private string endParkingDate;
        private string parkingPlace;
        private string cost;

        public Visit() {
        }

        public Visit(string fio, string carBrand, string carNumber, string carModel,  string startParkingDate, string endParkingDate, string parkingPlace, string cost) {
            this.Fio = fio;
            this.CarBrand = carBrand;
            this.CarNumber = carNumber;
            this.CarModel = carModel;
            this.startParkingDate = startParkingDate;
            this.endParkingDate = endParkingDate;
            this.parkingPlace = parkingPlace;
            this.cost = cost;
            
        }

        public string StartParkingDate { get => startParkingDate; set => startParkingDate = value; }
        public string EndParkingDate { get => endParkingDate; set => endParkingDate = value; }
        public string ParkingPlace { get => parkingPlace; set => parkingPlace = value; }
        public string Cost { get => cost; set => cost = value; }
        public string Fio { get => fio; set => fio = value; }
        public string CarBrand { get => carBrand; set => carBrand = value; }
        public string CarNumber { get => carNumber; set => carNumber = value; }
        public string CarModel { get => carModel; set => carModel = value; }

        public override bool Equals(object obj) {
            return obj is Visit visit &&
                   fio == visit.fio &&
                   carBrand == visit.carBrand &&
                   carNumber == visit.carNumber &&
                   carModel == visit.carModel &&
                   startParkingDate == visit.startParkingDate &&
                   endParkingDate == visit.endParkingDate &&
                   parkingPlace == visit.parkingPlace &&
                   cost == visit.cost &&
                   StartParkingDate == visit.StartParkingDate &&
                   EndParkingDate == visit.EndParkingDate &&
                   ParkingPlace == visit.ParkingPlace &&
                   Cost == visit.Cost &&
                   Fio == visit.Fio &&
                   CarBrand == visit.CarBrand &&
                   CarNumber == visit.CarNumber &&
                   CarModel == visit.CarModel;
        }

        public override int GetHashCode() {
            HashCode hash = new HashCode();
            hash.Add(fio);
            hash.Add(carBrand);
            hash.Add(carNumber);
            hash.Add(carModel);
            hash.Add(startParkingDate);
            hash.Add(endParkingDate);
            hash.Add(parkingPlace);
            hash.Add(cost);
            hash.Add(StartParkingDate);
            hash.Add(EndParkingDate);
            hash.Add(ParkingPlace);
            hash.Add(Cost);
            hash.Add(Fio);
            hash.Add(CarBrand);
            hash.Add(CarNumber);
            hash.Add(CarModel);
            return hash.ToHashCode();
        }
    }
}
