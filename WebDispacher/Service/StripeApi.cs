using DaoModels.DAO.Models;
using Stripe;
using System;
using System.Collections.Generic;

namespace WebDispacher.Service
{
    public class StripeApi
    {
        internal Customer CreateCustomer(string nameCommpany, int idCompany)
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
                customer = customerService.Create(customerOptions);
            }
            catch
            {

            }
            return customer;
        }

        internal Subscription CreateSupsctibe(string customer)
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
                subscription = subscriptionService.Create(subscriptionOptions);
            }
            catch { }
            return subscription;
        }

        internal Customer RemoveCustomer(Customer_ST customer_ST)
        {
            Customer customer = null;
            try
            {
                var service = new CustomerService();
                customer =  service.Delete(customer_ST.IdCustomerST);
            }
            catch
            { }
            return customer;
        }

        internal PaymentMethod CreatePaymentMethod(string number, string name, string expiry, string cvc)
        {
            PaymentMethod paymentMethod = null;
            int expMM = Convert.ToInt32(expiry.Remove(expiry.IndexOf("/")).Trim());
            int expYYYY = Convert.ToInt32(expiry.Remove(0, expiry.IndexOf("/") + 1).Trim());
            try
            {
                var options = new PaymentMethodCreateOptions
                {
                    Type = "card",
                    Card = new PaymentMethodCardCreateOptions
                    {
                        Number = number,
                        ExpMonth = expMM,
                        ExpYear = expYYYY,
                        Cvc = cvc
                    },
                };
                var service = new PaymentMethodService();
                paymentMethod = service.Create(options);
            }
            catch (Exception e)
            {

            }
            return paymentMethod;
        }

        internal void AttachPayMethod(string idPaymentMethod, string idCustomerST)
        {
            try
            {
                var options = new PaymentMethodAttachOptions
                {
                    Customer = idCustomerST,
                };
                var service = new PaymentMethodService();
                service.Attach(
                  idPaymentMethod,
                  options
                );
            }
            catch
            { }
        }
    }
}