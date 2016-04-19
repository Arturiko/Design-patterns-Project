using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Artur_308_Shay_300
{
    public enum eTypeOfForm
    {
        MainForm,
        StaticsForm,
        PhotoEditrForm
    }

    public static class FormFactory
    {
        public static Form CreateForm(eTypeOfForm i_TypeOfForm, object i_Parameters)
        {
            Form form = null;
            switch (i_TypeOfForm)
            {
                case eTypeOfForm.MainForm:
                    form = new FormFacebookMain();
                    break;
                case eTypeOfForm.PhotoEditrForm:
                    User user = i_Parameters as User;
                    form = new FormPhotoEditor(user);
                    break;
                case eTypeOfForm.StaticsForm:
                    form = new FormStatistics();
                    break;
            }

            return form;
        }
    }
}
