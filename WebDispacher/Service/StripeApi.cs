using Stripe;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebDispacher.Service
{
    public class StripeApi
    {
        internal async Task<Customer> CreateCustomer(string nameCommpany, int idCompany)
        {
            CustomerService customerService = new CustomerService();
            CustomerCreateOptions customerOptions = new CustomerCreateOptions
            {
                Name = $"{nameCommpany}_{idCompany}",
                Metadata = new Dictionary<string, string>()
                {
                    {"nameCommpany",  nameCommpany },
                    {"idCompany", idCompany.ToString() }
                }
            };
            Customer customer = await customerService.CreateAsync(customerOptions);
            return customer;
        }

        internal async Task CreateSupsctibe(string customer)
        {
            SubscriptionCreateOptions subscriptionOptions = new SubscriptionCreateOptions
            {
                Customer = customer,
                Items = new List<SubscriptionItemOptions>()
                {
                    new SubscriptionItemOptions()
                    {
                        Plan = "price_1H3j8FKfezfzRoxll5DR2VGl",
                    }
                }, 
                TrialPeriodDays = 30
            };
            var subscriptionService = new Stripe.SubscriptionService();

            var subscription = await subscriptionService.CreateAsync(subscriptionOptions);
        }
    }
}
