# Guard clause library for DotNet written in C#

```cs
using Fitomad.Guard;

...

public void BuyUseCase(PaymentEntity parameters)
{
    Guard.IsNotNull(parameters);
    Guard.Lenght(parameters.CreditCard.CVV, stringLenght: 3);
    Guard.Match(parameters.CreditCard.CVV, regularExpression: @"\d{3}");
    Guard.NotEmpty(parameters.CreditCard.OwnerName);
    Guard.NotEmpty(parameters.Cart);

    _repository.Buy(parameters);
}
```