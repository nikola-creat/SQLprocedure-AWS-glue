public string GenerateTimestamp(string timestamp, string offset)
{
    // timestamp comes from log file as [25/Dec/2017:00:14:58
    // offset comes from log file as -0500]
    // I need to trim the brackets and change the first : to a T

    string stamp, part1, part2;
    
    part1 = timestamp.Replace("[", "");
    part2 = offset.Replace("]", "");

    StringBuilder stampdate = new StringBuilder(part1);
    stampdate[11] = 'T';

    stamp = string.Concat(stampdate.ToString(), part2);

    return stamp;

}
