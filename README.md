# PayPalXamarinFormsIntegration
PayPal Xamarin Forms Integration Example
I have used in this example project PayPal.Forms nuget package. 
You can find all its details and how to use it here: https://github.com/AlejandroRuiz/PayPal.Forms

To be able to integrate with PayPal, you have to create and configure a PayPal Sandbox Account. Visit https://www.paypal.com/ae/webapps/mpp/account-selection and follow steps below to create and configure your own sandbox:

1.	Create PayPal Business Account.
2.	Login to PayPal Developer Portal using the account created before in step 1.
a.	Go to Sandbox -> Accounts Section and create two accounts that you will be used in Sandbox one as a Business (Merchant) account and the second one as a Personal (Buyer).
b.	Go to My Apps & Credentials Section and under "REST API apps" page section and create new application. Note that when creating a new application you have to select the business (merchant) account that you have created from previous step.
c.	After creating the App, Save the ClientId that will be used later in development.
3.	Login to PayPal Sandbox (https://www.sandbox.paypal.com/signin) with the business and personal account created before to make sure that your sandbox environment setup is done successfully.
