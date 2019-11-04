using TestApp.Pages;

namespace TestApp.Adapters
{
    class Vac : Vac_page
    {
        public p_filter Filter
        {
            get { return base.filter; }
        }

        public p_container Container
        {
            get { return base.container; }
        }

        public p_cookie_message Cookie_Message
        {
            get { return base.cookie_message; }
        }

    }
}
