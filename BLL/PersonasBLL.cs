using Microsoft.EntityFrameworkCore;
public class PersonasBLL
{
    private Contexto _contexto;
    public PersonasBLL(Contexto contexto)
    {
        _contexto = contexto;
    }
    public bool Guardar(Personas persona)
    {
        if(!Existe(persona.PersonaId))
            return Insertar(persona);
        else
            return Modificar(persona);
    }
    public bool Existe(int personaId){
        return _contexto.Personas.Any(p => p.PersonaId == personaId);
    }
    private bool Insertar(Personas persona){
        _contexto.Personas.Add(persona);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }
    private bool Modificar(Personas persona){
        _contexto.Entry(persona).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public Personas Buscar(int personaId){
        var persona = _contexto.Personas.Find(personaId);
        return persona;

    }
    public bool Eliminar(int Id){
        bool paso = false;
        try
        {
            var persona = _contexto.Personas.Find(Id);

            if(persona != null){
                _contexto.Personas.Remove(persona);
                paso = _contexto.SaveChanges() > 0;
            }
        }
        catch (Exception)
        {
            
            throw;
        }
        return paso;
    }
    public List<Personas> GetPersonas(){
        
        return _contexto.Personas.ToList();
    }
}