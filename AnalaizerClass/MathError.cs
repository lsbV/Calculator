using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public static class MathError
    {
        public static string Error01 { get; } = "Error 01 at <i> — Неправильна структура в дужках, помилка на <i> символі.";
        public static string Error02 { get; } = "Error 03 — Невірна синтаксична конструкція вхідного виразу.";
        public static string Error03 { get; } = "Error 02 at <i> — Невідомий оператор на <i> символі.";
        public static string Error04 { get; } = "Error 04 at <i> — Два підряд оператори на <i> символі.";
        public static string Error05 { get; } = "Error 05 — Незавершений вираз.";
        public static string Error06 { get; } = "Error 06 — Дуже мале, або дуже велике значення числа для int.";
        public static string Error07 { get; } = "Error 07 — Дуже довгий вираз. Максмальная довжина — 65536 символів.";
        public static string Error08 { get; } = "Error 08 — Сумарна кількість чисел і операторів перевищує 30.";
        public static string Error09 { get; } = "Error 09 – Помилка ділення на 0.";

    }
}
