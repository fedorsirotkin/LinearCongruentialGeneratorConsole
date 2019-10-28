using System;

namespace LinearCongruentialGenerator {
  /**
   * Основная программа
   */
  class Program {
    /**
     * Точка входа в программу
     */
    public static void Main() {
      Console.WriteLine("Добро пожаловать в программу \"Линейный конгруэнтный генератор\".");
      Console.Write("Сколько чисел сгенерировать? - ");
      var rng = new RandomNumberGenerator();
      var n = Convert.ToInt32(Console.ReadLine());
      const int maxn = 100;
      // Линейно-конгруэнтная последовательность
      for (int i = 0; i < n; i++) {
        var rnd = rng.Next(maxn);
        Console.WriteLine(rnd);
      }
      Console.WriteLine("Программа завершена. Нажмите клавишу для продолжения...");
      Console.ReadKey();
    }
  }

  /**
   * Линейный конгруэнтный генератор
   */
  class RandomNumberGenerator {
    private const long a = 1664525; // Множитель, где 0 <= a < m
    private const long c = 1013904223; // Приращение, где 0 <= с < m
    private const long m = 4294967296; // Модуль, где 0 < m (2^32)
    private long ni; // Случайная величина

    /**
     * Число тактов от текущей даты
     */
    public RandomNumberGenerator() {
      ni = DateTime.Now.Ticks % m;
    }

    /**
     * Получение случайной величины
     */
    public long Next() {
      ni = ((a * ni) + c) % m;
      return ni;
    }

    /**
     *  Получение случайной величины с учетом максимального значения
     */
    public long Next(long maxValue) {
      return Next() % maxValue;
    }
  }
}