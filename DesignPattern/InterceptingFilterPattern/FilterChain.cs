public class FilterChain
{
    private List<Filter> filters = new List<Filter>();
    private Target target;

    public void addFilter(Filter filter) => filters.Add(filter);

    public void Execute(string request)
    {
        foreach (Filter filter in filters)
            filter.Execute(request);
        target.Execute(request);
    }

    public void SetTarget(Target target) => this.target = target;
}