﻿
namespace SOLIDDemo.ISP;

public interface IDVD : ILibraryItem
{
    List<string> Actors { get; set; }

    int RuntimeInMinutes { get; set; }

}
