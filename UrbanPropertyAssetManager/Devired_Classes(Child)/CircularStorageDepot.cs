

namespace UrbanPropertyAssetManager
{

    public class CircularStorageDepot : PropertyAsset
    {
        public double Radius;

        public CircularStorageDepot(string code, double taxRate,
                                    double radius)
            : base(code, taxRate)
        {
            Radius = radius;
        }

        public override double ComputeFootprintArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double ComputeEnclosurePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

}
