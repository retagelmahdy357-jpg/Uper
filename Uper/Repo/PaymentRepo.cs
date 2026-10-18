using Uper.Data;
using Uper.DTO;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.Repo
{
    public class PaymentRepo:GenericRepo<Payment>,IPayment
    {
        private readonly AppDbContext _context;
        public PaymentRepo(AppDbContext context):base(context)
        {
            _context = context; 
        }

        public async Task<StaticsDTO> StaticsPayment()
        {
            var p = _context.Payment;
            var statics = new StaticsDTO
            {
                TotalPayment = p.Count(),
                totalamount = p.Sum(x => x.Amount),
                totalcash = p.Count(x => x.PaymentMethod == "Cash"),
                TotalCard = p.Count(x => x.PaymentMethod == "Card"),
                TotalPaied = p.Count(x => x.Status == "Paied"),
                TotalPending = p.Count(x => x.Status == "Pending")
            };
           return  statics;
        }
    }
}
