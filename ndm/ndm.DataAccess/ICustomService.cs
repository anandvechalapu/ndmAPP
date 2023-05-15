<code>using ndm.DTO;

namespace ndm.Service
{
    public class CustomService
    {
        public List&lt;Custom&gt; GetCustoms()
        {
            // implementation
        }
    }
}
</code>

<code>using ndm.DTO;

namespace ndm.Service
{
    public interface ICustomService
    {
        List&lt;Custom&gt; GetCustoms();
    }
}
</code>
