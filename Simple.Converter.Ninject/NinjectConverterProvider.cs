using Ninject;

namespace Simple.Converter.Ninject
{
    public class NinjectConverterProvider : IConverterProvider
    {
        private readonly IKernel _kernel;

        public NinjectConverterProvider(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IConverter<TFrom, TTo> Get<TFrom, TTo>()
        {
            return _kernel.Get<IConverter<TFrom, TTo>>();
        }
    }
}
