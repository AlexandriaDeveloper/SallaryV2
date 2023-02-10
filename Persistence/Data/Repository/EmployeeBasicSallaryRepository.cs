using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    internal class EmployeeBasicSallaryRepository : Repository<EmployeeBasicSallary>, IEmployeeBasicSallaryRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeeBasicSallaryRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
            this._authService = authService;
        }

        public async Task<EmployeeBasicSallary> EmployeeGetRaise(
            int employeeId,
            int newFinancialYear,
            decimal? wazifiPercentage,
            decimal? wazifiAmount,
            decimal? wazifiMinAmount,
            decimal? wazifiMaxAmount,
            decimal? mokamelPercentage,
            decimal? mokamelAmount,
            decimal? mokamelMinAmount,
            decimal? mokamelMaxAmount
            )
        {
            //check employee and financial year exist



            //Get Existing Employee Last Sallary Data 
            var lastSallary = await _context.EmployeeBasicSallaries
                .Where(e => e.EmployeeId == employeeId)
                .OrderByDescending(x => x.CreatedDate)
                .Select(t => t).FirstAsync();


            EmployeeBasicSallary newSallary = new EmployeeBasicSallary();
            newSallary.EmployeeId = lastSallary!.EmployeeId;
            newSallary.FinancialYearId = newFinancialYear;
            newSallary.Taawidi = lastSallary.Taawidi;
            newSallary.BasicSallary = lastSallary.BasicSallary;

            newSallary.Wazifi = lastSallary.Wazifi;
            newSallary.Mokamel = lastSallary.Mokamel;
            if (wazifiPercentage != null)
            {
                newSallary.Wazifi = await CaluclateRaiseByPercentage(newSallary.Wazifi, wazifiPercentage, wazifiMinAmount, wazifiMaxAmount);
            }

            if (wazifiAmount != null)
            {
                newSallary.Wazifi = await CaluclateRaiseByFixedAmount(newSallary.Wazifi, wazifiAmount);
            }

            if (mokamelPercentage != null)
            {
                newSallary.Mokamel = await CaluclateRaiseByPercentage(newSallary.Mokamel, mokamelPercentage, mokamelMinAmount, mokamelMaxAmount);
            }
            if (mokamelAmount != null)
            {
                newSallary.Mokamel = await CaluclateRaiseByFixedAmount(newSallary.Mokamel, mokamelAmount);
            }

            if (mokamelMaxAmount != null)
            {
                newSallary.Mokamel = await CaluclateRaiseByFixedAmount(newSallary.Mokamel, mokamelAmount);
            }
            // var existingEmployeeData = _context.

            //
            return newSallary;


        }

        public async Task<EmployeeBasicSallary?> GetLastEmployeeBasicSallaryAsync(int employeeId)
        {
            return await _context.EmployeeBasicSallaries.OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync(x => x.EmployeeId == employeeId);

        }
        public async Task<EmployeeBasicSallary?> GetEmployeeBasicSallaryByFinancialIdAsync(int employeeId, int financialYearId) => await _context.EmployeeBasicSallaries.OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync(x => x.EmployeeId == employeeId && x.FinancialYearId == financialYearId);

        private async Task<decimal?> CaluclateRaiseByPercentage(decimal? AmountBefor, decimal? Percentage, decimal? HasMin, decimal? HasMax)
        {

            if (!AmountBefor.HasValue) { return null; }

            decimal? amountAfter = null;
            if (!AmountBefor.HasValue || !Percentage.HasValue)
            {
                return null;
            }

            decimal incresedAmount = Math.Round(AmountBefor.Value * Percentage.Value / 100, 2);

            if (HasMin.HasValue)
            {
                incresedAmount = CheckMin(incresedAmount, HasMin.Value);
            }
            if (HasMax.HasValue)
            {
                incresedAmount = checkMax(incresedAmount, HasMax.Value);
            }

            amountAfter = Math.Round(AmountBefor.Value + incresedAmount, 2);

            return amountAfter;
        }
        private async Task<decimal?> CaluclateRaiseByFixedAmount(decimal? AmountBefor, decimal? Amount)
        {

            if (!AmountBefor.HasValue) { return null; }


            decimal? amountAfter = null;
            if (!AmountBefor.HasValue || !Amount.HasValue)
                return null;




            amountAfter = Math.Round(AmountBefor.Value + Amount.Value, 2);
            return amountAfter;
        }

        private decimal CheckMin(decimal currentRaise, decimal minRaise)
        {
            return minRaise > currentRaise ? minRaise : currentRaise;
        }
        private decimal checkMax(decimal currentRaise, decimal maxRais)
        {
            return currentRaise > maxRais ? maxRais : currentRaise;
        }
    }
}
