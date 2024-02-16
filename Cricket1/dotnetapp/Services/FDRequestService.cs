// FDRequestService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Data;

namespace dotnetapp.Services
{
    public class FDRequestService
    {
        private readonly ApplicationDbContext _context;

        public FDRequestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FDRequest>> GetAllFDRequests()
        {
            return await _context.FDRequests.ToListAsync();
        }

        public async Task<FDRequest> GetFDRequestById(long requestId)
        {
            return await _context.FDRequests
                .FirstOrDefaultAsync(fr => fr.FDRequestId == requestId);
        }

        public async Task<bool> AddFDRequest(FDRequest fdRequest)
        {
            try
            {
                _context.FDRequests.Add(fdRequest);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                // Handle exception as needed
                return false;
            }
        }

        // Additional methods for update, delete, or other business logic
// FDRequestService.cs
// ... (existing code)

public async Task<bool> UpdateFDRequest(long requestId, FDRequest updatedFDRequest)
{
    try
    {
        var existingFDRequest = await _context.FDRequests
            .FirstOrDefaultAsync(fr => fr.FDRequestId == requestId);

        if (existingFDRequest == null)
        {
            return false; // FDRequest not found
        }

        // Update properties of existingFDRequest with properties of updatedFDRequest
        existingFDRequest.Property1 = updatedFDRequest.Property1;
        existingFDRequest.Property2 = updatedFDRequest.Property2;
        // ... (update other properties as needed)

        await _context.SaveChangesAsync();
        return true;
    }
    catch (Exception)
    {
        // Handle exception as needed
        return false;
    }
}

public async Task<bool> DeleteFDRequest(long requestId)
{
    try
    {
        var fdRequest = await _context.FDRequests
            .FirstOrDefaultAsync(fr => fr.FDRequestId == requestId);

        if (fdRequest == null)
        {
            return false; // FDRequest not found
        }

        _context.FDRequests.Remove(fdRequest);
        await _context.SaveChangesAsync();
        return true;
    }
    catch (Exception)
    {
        // Handle exception as needed
        return false;
    }
}


    }
}
