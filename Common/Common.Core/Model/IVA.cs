namespace Common.Core.Model
{
    public class IVA : Entity<int>
    {
        public decimal Valor { get; private set; }

        protected IVA() : base(false)
        {
        }
    }
}
