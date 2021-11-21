Aplikacja pobiera z bazy danych informacje o samochodach, następnie wylicza procent zniżki dla danego auta i wyświetla informacje o samochodzie, 
wraz z przeliczoną ceną po obniżce.

Baza danych (projekt CarDiscountsDatabase) udostępnia na zewnątrz interfejs IDatabaseCar.
Mockup bazy danych generowany jest poprzez metodę Database.FillEcampleOfDatabase().

Warstwa biznesowa mapuje dane z bazy danych (w postaci List<IDatabaseCar) na słownik elementów typu BusinessCar, dodając do każdego z nich id
oraz wyliczając procent zniżki dla danego pojazdu (reszta z dzielenia id pojazdu przez 100).
Punktem startowym programu jest Main() w pliku CarDiscountsCalculator.cs.
Zawarta w nim klasa Program posiada jeszcze dwie ważne metody:
- PrintCars(), która odpowiada za wyświetlanie wyników działania programu
- FilterByMaxPriceAfterDiscount(), która umożliwia proste filtrowanie samochodów po maksymalnej ich cenie po obniżce, którą jesteśmy zainteresowani
  (metoda ta z pewnością powinna się znaleźć w zupełnie innej klasie, ale niestety, zabrakło mi czasu na odpowiednie jej umiejscowienie)
