using SayurAPI.Models;

namespace SayurAPI.Services;

public static class SayurService
{
    static List<Sayur> Sayurs { get; }
    static int nextId = 3;
    static SayurService()
    {
        Sayurs = new List<Sayur>
        {
            new Sayur { Id = 1, Name = "Tomato", IsAvailable = true },
            new Sayur { Id = 2, Name = "Chili", IsAvailable = false }
        };
    }
    public static List<Sayur> GetAll() => Sayurs;
    public static Sayur? Get(int id) => Sayurs.FirstOrDefault(p => p.Id == id);
    public static void Add(Sayur sayur)
    {
        sayur.Id = nextId++;
        Sayurs.Add(sayur);
    }
    public static void Delete(int id)
    {
        var sayur = Get(id);
        if (sayur is null)
            return;
        Sayurs.Remove(sayur);
    }
    public static void Update(Sayur sayur)
    {
        var index = Sayurs.FindIndex(p => p.Id == sayur.Id);
        if (index == -1)
            return;
        Sayurs[index] = sayur;
    }
}