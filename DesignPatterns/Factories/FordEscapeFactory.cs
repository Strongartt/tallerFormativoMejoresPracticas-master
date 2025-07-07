using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;
namespace DesignPatterns.Factories
{
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .setColor("grey")
                .Build();
        }
    }
}
