using System.Text;
using UnitMeasures;

namespace MobilePhone.BL
{
    public class ScreenBase
    {
        public string Technology{ get; set; }
        public Mass Weight { get; set; }
        public Length Hight { get; set; }
        public Length Width  { get; set; }
        public Angle ViewingAngle { get; set; }

        public override string ToString()
        {
                var showBuilder = new StringBuilder();
                showBuilder.AppendLine($"Screen Technology: {Technology.ToString()}");
                showBuilder.AppendLine($"Screen Weight: {Weight.ToString()}");
                showBuilder.AppendLine($"Screen Hight: {Hight.ToString()}");
                showBuilder.AppendLine($"Screen Width: {Width.ToString()}");
                showBuilder.AppendLine($"Screen Viewing Angle: {ViewingAngle.ToString()}");
                return showBuilder.ToString();
            }
        }
 }
