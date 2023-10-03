
using SolidPrinciples.Ocp;

public class PaymentService1
{

  public void Process(OrderPaymentInfo paymentInfo)
  {
    if (paymentInfo.Type == PaymentType.Credit)
    {
      // Integrate to Gateway of Payment A
    }
    else if (paymentInfo.Type == PaymentType.Debit)
    {
      // Integrate to Gateway of Payment B
    }
  }

}
public class OrderPaymentInfo
{
  public PaymentType Type { get; set; }
}
