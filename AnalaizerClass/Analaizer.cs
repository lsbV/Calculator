namespace AnalaizerClass
{
    public class Analaizer
    {
        /// <summary>
        /// позиція виразу, на якій знайдена синтаксична помилка (у випадку відловлення на рівні виконання - не визначається)
        /// </summary>
        private static int erposition = 0;
        /// <summary>
        /// Вхідний вираз
        /// </summary>
        public static string expression = "";
        /// <summary>
        /// Показує, чи є необхідність у виведенні повідомлень про помилки. У разі консольного запуску програми це значення - false.
        /// </summary>
        public static bool ShowMessage = true;
        /// <summary>
        /// Перевірка коректності структури в дужках вхідного виразу 
        /// </summary>
        /// <returns>true - якщо все нормально, false- якщо є помилка</returns>
        /// метод біжить по вхідному виразу, символ за символом аналізуючи його, і рахуючи кількість дужок.У разі виникнення
        /// помилки повертає false, а в erposition записує позицію, на якій виникла помилка.
        public static bool CheckCurrency()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Форматує вхідний вираз, виставляючи між операторами пропуски і видаляючи зайві, а також знаходить нерозпізнані оператори, стежить за кінцем рядка
        /// а також знаходить помилки в кінці рядка
        /// </summary>
        /// <returns>кінцевий рядок або повідомлення про помилку, що починаються з спец.символу &</returns>
        public static string Format()
        {
            throw new NotImplementedException();

        }
        /// <summary>
        /// Формує масив, в якому розташовуються оператори і символи представлені в зворотному польському записі(без дужок)
        /// На цьому ж етапі відшукується решта всіх помилок (див. код). По суті - це компіляція.
        /// </summary>
        /// <returns>массив зворотнього польського запису</returns>
        public static System.Collections.ArrayList CreateStack()
        {
            throw new NotImplementedException();

        }
        /// <summary>
        /// Обчислення зворотнього польського запису
        /// </summary>
        ///<returns>результат обчислень,або повідомлення про помилку</returns>
        public static string RunEstimate()
        {
            throw new NotImplementedException();

        }
        /// <summary>
        /// Метод, який організовує обчислення. По черзі запускає CheckCorrncy, Format, CreateStack і RunEstimate
        /// </summary>
        /// <returns></returns>
        public static string Estimate()
        {
            throw new NotImplementedException();

        }
    }
}