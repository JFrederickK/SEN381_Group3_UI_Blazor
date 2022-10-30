namespace SEN381_UI.Shared.AbstractClasses
{
    public abstract class IBrowsedResponse<T>
    {
        List<T> items;
        int page;
        int size;
        int totalCount;
        int totalPages;

    }
}
