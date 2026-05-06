using Microsoft.EntityFrameworkCore.Storage;
using mska_data.Models;
using mska_data.Repositories;
using mska_data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MskacenterDbContext _context;
    private IDbContextTransaction? _transaction;

    private IUserRepository? _users;
    private ICourseRepository? _course;

    public UnitOfWork(MskacenterDbContext context)
    {
        _context = context;
    }

    public IUserRepository Users
        => _users ??= new UserRepository(_context);

    public ICourseRepository Course
       => _course ??= new CourseRepository(_context);


    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    public void BeginTransaction()
    {
        if (_transaction == null)
            _transaction = _context.Database.BeginTransaction();
    }

    public void Commit()
    {
        if (_transaction != null)
        {
            _context.SaveChanges();
            _transaction.Commit();
            _transaction.Dispose();
            _transaction = null;
        }
    }

    public void Rollback()
    {
        if (_transaction != null)
        {
            _transaction.Rollback();
            _transaction.Dispose();
            _transaction = null;
        }
    }

    public void Dispose()
    {
        _transaction?.Dispose();
        _context.Dispose();
    }
}