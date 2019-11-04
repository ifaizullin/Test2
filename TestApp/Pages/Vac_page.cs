using TestApp.Controls;

namespace TestApp.Pages
{
    class Vac_page : Pages
    {
        public Vac_page()
        {
            p_address = "http://careers.veeam.com/";
        }
        
        protected p_filter filter { get; } = new p_filter();
        protected p_container container { get; } = new p_container();
        protected p_cookie_message cookie_message { get; } = new p_cookie_message();

        public class p_filter
        {
            public Selector Country { get; }
            public Selector City { get; }
            public Selector Function { get; }
            public Selector Language { get; }
        public p_filter()
            {
                Country = new Selector("#country-element .selecter.closed .selecter-selected", ".scroller-content span");
                City = new Selector("#city-element .selecter.closed .selecter-selected", "scroller-content span");
                Function = new Selector("#department-element .selecter.closed .selecter-selected", "scroller-content span");
                Language = new InputSelector("#language.selecter-fieldset.selecter", ".scroller-content label", ".selecter-fieldset-submit");
            }

        }
        public class p_container
        {
            public Widjet Widjets { get; }
            public Button ShowAll { get; }
            public p_container()
            {
                Widjets = new Widjet(".vacancies-blocks-container.vacancies-blocks-item");
                ShowAll = new Button(".content-loader-button.load-more-button");
            }
        }

        public class p_cookie_message
        {
            public Button Button { get; }
            public p_cookie_message()
            {
                Button = new Button(".cookie-messaging__button.js-btn-close");
            }
        }
    }
}
