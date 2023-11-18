using SmthThatIDoNotWantToDo.Models;

namespace SmthThatIDoNotWantToDo
{
    //NOTE: Вычисление площади фигуры без знания типа фигуры в compile-time
    //На этапе компиляции конкретный тип фигуры не известен, но известно что это наследник абстрактного FigureBase который содержит абстрактный метод GetArea
    // Сделано так, как было сказано в требованиях, если же нет, пишите требования более точно. 
    public static class AreaCalculator
    {
        public static double CalculateArea(FigureBase figure)
        {
            return figure.GetArea();
        }
    }
}
