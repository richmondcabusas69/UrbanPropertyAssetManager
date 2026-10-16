
namespace UrbanPropertyAssetManager
{
    public class TriangularPark : PropertyAsset
    {
        public double BaseSpan;
        public double Height;
        public double Side1;
        public double Side2;
        public double Side3;

        public TriangularPark(string code, double taxRate,
            double baseSpan, double height,double side1, 
            double side2, double side3)
            : base(code, taxRate)
        {
            BaseSpan = baseSpan;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double ComputeFootprintArea()
        {
            return 0.5 * BaseSpan * Height;
        }

        public override double ComputeEnclosurePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }

}
