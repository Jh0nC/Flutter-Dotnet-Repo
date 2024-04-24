import 'dart:math' show pi, pow;

void main(List<String> args) {

  Circulo circulo = Circulo(radio: 1);

  print(circulo.toString());

  print(circulo.caclArea());
  print(circulo.calcPerimetro());

}

class Circulo {
  double radio;

  //constructor
  Circulo({required double this.radio});

  //methods
  double caclArea() {
    double areaCirculo = pi * pow(this.radio, 2);
    return areaCirculo;
  }

  double calcPerimetro() {
    double perimetroCirculo = 2 * pi * this.radio;
    return perimetroCirculo;
  }

  @override
  String toString() {
    return ' radio: ${this.radio}\n area: ${this.caclArea()}\n perimetro: ${this.calcPerimetro()}';
  }
}
