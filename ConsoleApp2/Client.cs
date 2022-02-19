using System;
using System.Collections.Generic;
using System.Text;

namespace lrNet1 {
    class Client {
        private string fio;
        private Car car;

        public Client() {
        }

        public Client(string fio, Car car) {
            this.fio = fio;
            this.car = car;
        }
        
        public string Fio { get => fio; set => fio = value; }
        
        public Car Car { get => car; set => car = value; }

        public override bool Equals(object obj) {
            return obj is Client client &&
                   fio == client.fio &&
                   EqualityComparer<Car>.Default.Equals(car, client.car) &&
                   Fio == client.Fio &&
                   EqualityComparer<Car>.Default.Equals(Car, client.Car);
        }

        public override int GetHashCode() {
            return HashCode.Combine(fio, car, Fio, Car);
        }
    }
}
