namespace Utils;

public class Util {
    public static int[] FilterEvenNumber(int[] array) {
        var numQuery =
            from num in array
            where (num % 2) == 0
            select num;
        return (int[]) numQuery.ToArray();
    }

    public static int? First(int[] array) {
        if (array.Length == 0) return null;
        var query = from num in array select num;
        return (int?) Convert.ToInt32(query.FirstOrDefault());
    }

    public static int? Last(int[] array) {
        if (array.Length == 0) return null;
        var query = from num in array select num;
        return (int?) Convert.ToInt32(query.LastOrDefault());
    }

    // Both of Single and SingleOrDefault throw an Exception if result has two or more satisfying value.
    public static int? Single(int[] array) {
        if (array.Length == 0) return null;
        var query = from num in array select num;
        return (int?) Convert.ToInt32(query.SingleOrDefault());
    }
}