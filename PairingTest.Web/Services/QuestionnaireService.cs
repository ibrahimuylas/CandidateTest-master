using PairingTest.Web.Models;
using System.Threading.Tasks;

namespace PairingTest.Web.Services
{
    public class QuestionnaireService : ServiceBase<QuestionnaireService>
    {        
        internal async Task<QuestionnaireViewModel> GetQuestionsAsync()
        {
           return await base.GetDataFromAPI< QuestionnaireViewModel>("questions");
        }
    }
}