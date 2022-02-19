using System;
using System.Collections.Generic;
using System.Text;

namespace lrNet1 {
    class Car {
        private string brand;
        private string number;
        private string model;

        public Car() {
        }

        public Car(string brand, string number, string model) {
            this.brand = brand;
            this.number = number;
            this.model = model;
        }

        public string Brand { get => brand; set => brand = value; }
        
        public string Number { get => number; set => number = value; }
        
        public string Model { get => model; set => model = value; }

        public override bool Equals(object obj) {
            return obj is Car car &&
                   brand == car.brand &&
                   number == car.number &&
                   model == car.model &&
                   Brand == car.Brand &&
                   Number == car.Number &&
                   Model == car.Model;
        }

        public override int GetHashCode() {
            return HashCode.Combine(brand, number, model, Brand, Number, Model);
        }
    }
}
