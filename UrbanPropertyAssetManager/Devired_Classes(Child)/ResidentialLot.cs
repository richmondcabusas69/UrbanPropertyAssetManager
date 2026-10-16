

namespace UrbanPropertyAssetManager
{
    public class ResidentialLot : PropertyAsset
    {
        public double Frontage;
        public double Depth;

        public ResidentialLot(string code, double taxRate,
                              double frontage, double depth)
            : base(code, taxRate)
        {
            Frontage = frontage;
            Depth = depth;
        }

        public override double ComputeFootprintArea()
        {
            return Frontage * Depth;
        }

        public override double ComputeEnclosurePerimeter()
        {
            return 2 * (Frontage + Depth);
        }
    }

}
