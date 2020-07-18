using DaoModels.DAO.Models;
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
            Customer customer = null;
            try
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
                customer = await customerService.CreateAsync(customerOptions);
            }
            catch
            {

            }
            return customer;
        }

        internal async Task<Subscription> CreateSupsctibe(string customer)
        {
            Subscription subscription = null;
            try
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
                subscription = await subscriptionService.CreateAsync(subscriptionOptions);
            }
            catch { }
            return subscription;
        }

        internal async Task<Customer> RemoveCustomer(Customer_ST customer_ST)
        {
            Customer customer = null;
            try
            {
                var service = new CustomerService();
                customer = await service.DeleteAsync(customer_ST.IdCustomerST);
            }
            catch
            { }
            return customer;
        }
    }
}