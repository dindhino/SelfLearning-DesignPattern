public class FilterManager
{
    FilterChain filterChain;

    public FilterManager(Target target)
    {
        filterChain = new FilterChain();
        filterChain.SetTarget(target);
    }

    public void SetFilter(Filter filter) => filterChain.addFilter(filter);
    public void FilterRequest(string request) => filterChain.Execute(request);
}