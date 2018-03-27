namespace Sitecore.Support.XA.Foundation.Variants.Abstractions.Pipelines.IoC
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.XA.Foundation.IOC.Pipelines.IOC;
  using Sitecore.XA.Foundation.Variants.Abstractions.Renderers;
  using Sitecore.XA.Foundation.Variants.Abstractions.Services;

  public class RegisterVariantsAbstractionsServices : IocProcessor
  {
    public override void Process(IocArgs args)
    {
      args.ServiceCollection.AddTransient<IVariantFieldParser, VariantFieldParser>();
      args.ServiceCollection.AddSingleton<ITemplateRenderer, Sitecore.Support.XA.Foundation.Variants.Abstractions.Services.TemplateRenderer>();
      args.ServiceCollection.AddTransient<IVariantRenderer, VariantRenderer>();
      args.ServiceCollection.AddTransient<IAvailableRenderingVariantService, AvailableRenderingVariantService>();
      args.ServiceCollection.AddTransient<IVariantRenderingService, VariantRenderingService>();
      args.ServiceCollection.AddTransient<IRulesService, RulesService>();
    }
  }
}