
namespace UrbanPropertyAssetManager
{
    public abstract class PropertyAsset
    {
        public string PropertyCode;
        public double TaxRatePerUnitArea;

        public PropertyAsset(string code, double taxRate)
        {
            PropertyCode = code;
            TaxRatePerUnitArea = taxRate;
        }

        public abstract double ComputeFootprintArea();

        public abstract double ComputeEnclosurePerimeter();

        public virtual double ComputeEstimatedTax()
        {
            return ComputeFootprintArea() * TaxRatePerUnitArea;
        }
    }

}

