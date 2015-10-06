namespace PrismKata.ViewModels
{
    public class ViewAViewModel
    {
        private string _firstName = "John";
        // Add properties for remaing View bindings: LastName, LastUpdated

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value; 
                // Add Prop. Change Notification
            }
        }

        // Add Command binding
    }
}