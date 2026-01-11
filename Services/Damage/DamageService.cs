using System;
using System.Collections.Generic;
using VRMS.Models.Damages;
using VRMS.Repositories.Damages;

namespace VRMS.Services.Damage;

/// <summary>
/// Provides business logic for damage management, including:
/// - Damage catalog maintenance (definitions and estimated costs)
/// - Damage report creation and approval
/// - Damage report photo management
///
/// This service enforces validation rules and approval state
/// while delegating persistence to repositories.
/// </summary>
public class DamageService
{
    /// <summary>
    /// Repository for damage catalog entries.
    /// </summary>
    private readonly DamageRepository _damageRepo;

    /// <summary>
    /// Repository for damage reports.
    /// </summary>
    private readonly DamageReportRepository _reportRepo;

    /// <summary>
    /// Initializes the damage service.
    /// </summary>
    public DamageService()
    {
        _damageRepo = new DamageRepository();
        _reportRepo = new DamageReportRepository();
    }

    // ----------------------------
    // DAMAGE CATALOG
    // ----------------------------

    /// <summary>
    /// Creates a new damage definition in the damage catalog.
    /// </summary>
    /// <param name="description">Damage description</param>
    /// <param name="estimatedCost">Estimated repair cost</param>
    /// <returns>Newly created damage ID</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when description is empty or cost is negative
    /// </exception>
    public int CreateDamage(
        string description,
        decimal estimatedCost)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidOperationException(
                "Damage description is required.");

        if (estimatedCost < 0)
            throw new InvalidOperationException(
                "Estimated cost cannot be negative.");

        return _damageRepo.Create(
            description,
            estimatedCost);
    }

    /// <summary>
    /// Updates an existing damage definition.
    /// </summary>
    /// <param name="damageId">Damage ID</param>
    /// <param name="description">Updated description</param>
    /// <param name="estimatedCost">Updated estimated cost</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when description is empty or cost is negative
    /// </exception>
    public void UpdateDamage(
        int damageId,
        string description,
        decimal estimatedCost)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidOperationException(
                "Damage description is required.");

        if (estimatedCost < 0)
            throw new InvalidOperationException(
                "Estimated cost cannot be negative.");

        // Ensure damage exists
        _damageRepo.GetById(damageId);

        _damageRepo.Update(
            damageId,
            description,
            estimatedCost);
    }

    /// <summary>
    /// Deletes a damage definition from the catalog.
    /// </summary>
    public void DeleteDamage(int damageId)
    {
        _damageRepo.Delete(damageId);
    }

    /// <summary>
    /// Retrieves a damage definition by ID.
    /// </summary>
    public Models.Damages.Damage GetDamageById(int damageId)
    {
        return _damageRepo.GetById(damageId);
    }

    /// <summary>
    /// Retrieves all damage definitions.
    /// </summary>
    public List<Models.Damages.Damage> GetAllDamages()
    {
        return _damageRepo.GetAll();
    }

    // ----------------------------
    // DAMAGE REPORTS
    // ----------------------------

    /// <summary>
    /// Creates a new damage report for a vehicle inspection.
    /// </summary>
    /// <param name="vehicleInspectionId">Vehicle inspection ID</param>
    /// <param name="damageId">Damage definition ID</param>
    /// <returns>Newly created damage report ID</returns>
    public int CreateDamageReport(
        int vehicleInspectionId,
        int damageId)
    {
        // Ensure referenced damage exists
        _damageRepo.GetById(damageId);

        return _reportRepo.Create(
            vehicleInspectionId,
            damageId);
    }

    /// <summary>
    /// Approves a damage report.
    ///
    /// Approved damage reports are considered billable
    /// and cannot be approved again.
    /// </summary>
    /// <param name="damageReportId">Damage report ID</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the report is already approved
    /// </exception>
    public void ApproveDamageReport(int damageReportId)
    {
        var report =
            _reportRepo.GetById(damageReportId);

        if (report.Approved)
            throw new InvalidOperationException(
                "Damage report is already approved.");

        _reportRepo.Approve(
            damageReportId);
    }

    /// <summary>
    /// Retrieves a damage report by ID.
    /// </summary>
    public DamageReport GetDamageReportById(int damageReportId)
    {
        return _reportRepo.GetById(damageReportId);
    }

    /// <summary>
    /// Retrieves all damage reports for a specific vehicle inspection.
    /// </summary>
    public List<DamageReport> GetDamageReportsByInspection(
        int vehicleInspectionId)
    {
        return _reportRepo.GetByInspection(
            vehicleInspectionId);
    }

    /// <summary>
    /// Sets or replaces the photo associated with a damage report.
    /// </summary>
    public void SetDamageReportPhoto(
        int damageReportId,
        string photoPath)
    {
        _reportRepo.SetPhoto(
            damageReportId,
            photoPath);
    }

    /// <summary>
    /// Removes the photo associated with a damage report.
    /// </summary>
    public void DeleteDamageReportPhoto(int damageReportId)
    {
        _reportRepo.ResetPhoto(
            damageReportId);
    }
}
