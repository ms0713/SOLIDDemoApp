namespace SOLIDDemo;

public  class TableServers
{
    private static readonly TableServers m_TableServers = new TableServers();
    private List<string> m_Servers = new();
    private int m_ServerIndex = 0;

    public TableServers()
    {
        m_Servers.Add("Milan");
        m_Servers.Add("Nayan");
        m_Servers.Add("Pratik");
        m_Servers.Add("Rajesh");
    }

    public TableServers GetTableServers()
    {
        return m_TableServers;
    }

    public string GetNextServer()
    {
        string output = m_Servers[m_ServerIndex];

        m_ServerIndex++;

        if (m_ServerIndex >= m_Servers.Count)
        {
            m_ServerIndex = 0;
        }

        return output;
    }
}
