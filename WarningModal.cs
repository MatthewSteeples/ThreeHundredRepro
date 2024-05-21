namespace ThreeHundredRepro
{
    public class WarningModal
    {
        public WarningModal(string modalId, string modalTitle, string message)
        {
            ModalId = modalId;
            ModalTitle = modalTitle;
            Message = message;
        }

        public WarningModal()
        {
        }

        public string ModalId { get; set; }
        public string ModalTitle { get; set; }
        public string Message { get; set; }
        public string ConfirmUrl { get; set; }
        public bool BoolProperty { get; set; }
    }
}
