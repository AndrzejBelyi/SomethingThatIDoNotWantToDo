namespace SmthThatIDoNotWantToDo.Models
{
    //NOTE: Вычисление площади фигуры без знания типа фигуры в compile-time
    //На этапе компиляции конкретный тип фигуры не известен, но известно что это наследник абстрактного FigureBase который содержит абстрактный метод GetArea
    // Сделано так, как было сказано в требованиях, если же нет, пишите требования более точно. 
    public abstract class FigureBase
    {
        public abstract double GetArea();
    }
}
