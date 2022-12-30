public class CriteriaMale : Criteria
{
    List<Person> Criteria.MeetCriteria(List<Person> persons) => persons.Where(x => x.GetGender().ToUpper() == "MALE".ToUpper()).ToList();
}

public class CriteriaFemale : Criteria
{
    List<Person> Criteria.MeetCriteria(List<Person> persons) => persons.Where(x => x.GetGender().ToUpper() == "FEMALE".ToUpper()).ToList();
}

public class CriteriaSingle : Criteria
{
    List<Person> Criteria.MeetCriteria(List<Person> persons) => persons.Where(x => x.GetMaritalStatus().ToUpper() == "SINGLE".ToUpper()).ToList();
}

public class AndCriteria : Criteria
{
    private Criteria criteria;
    private Criteria otherCriteria;

    public AndCriteria(Criteria criteria, Criteria otherCriteria)
    {
        this.criteria = criteria;
        this.otherCriteria = otherCriteria;
    }

    List<Person> Criteria.MeetCriteria(List<Person> persons) => otherCriteria.MeetCriteria(criteria.MeetCriteria(persons));
}

public class OrCriteria : Criteria
{
    private Criteria criteria;
    private Criteria otherCriteria;

    public OrCriteria(Criteria criteria, Criteria otherCriteria)
    {
        this.criteria = criteria;
        this.otherCriteria = otherCriteria;
    }

    List<Person> Criteria.MeetCriteria(List<Person> persons)
    {
        List<Person> criteriaItems = otherCriteria.MeetCriteria(persons);
        criteriaItems.AddRange(criteria.MeetCriteria(persons));
        return criteriaItems.Distinct().ToList();
    }
}