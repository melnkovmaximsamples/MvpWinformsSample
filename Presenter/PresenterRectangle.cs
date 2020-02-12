using MVP_Sample.Model;
using MVP_Sample.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Sample.Presenter
{
    public class PresenterRectangle
    {
        IRectangle rectangleView;

        public PresenterRectangle(IRectangle rectangleView)
        {
            this.rectangleView = rectangleView;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle() { length = double.Parse(rectangleView.lengthText), width = double.Parse(rectangleView.widthText) };
            rectangleView.resultText = rectangle.result.ToString();
        }
    }
}
