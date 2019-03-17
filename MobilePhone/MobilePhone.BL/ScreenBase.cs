using System.Text;
using NGenericDimensions;
using NGenericDimensions.Masses.MetricSI;
using NGenericDimensions.Lengths.MetricSI;

namespace MobilePhone.BL
{
    public class ScreenBase
    {
        public string Technology{ get; protected internal set; }
        public Mass<Kilograms, double> Weight { get; protected internal set; }
        public Length<Metres, double> Hight { get; protected internal set; }
        public Length<Metres, double> Width  { get; protected internal set; }

        public override string ToString()
        {
                var showBuilder = new StringBuilder();
                showBuilder.AppendLine($"Screen Technology: {Technology.ToString()}");
                showBuilder.AppendLine($"Screen Weight: {Weight.MassValue} {Weight.UnitOfMeasure.ToString().Substring(35)}");
                showBuilder.AppendLine($"Screen Hight: {Hight.LengthValue} {Hight.UnitOfMeasure.ToString().Substring(36)}");
                showBuilder.AppendLine($"Screen Width: {Width.LengthValue} {Width.UnitOfMeasure.ToString().Substring(36)}");
                return showBuilder.ToString();
            }
        }
 }
