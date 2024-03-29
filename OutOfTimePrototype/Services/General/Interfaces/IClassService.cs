﻿using OutOfTimePrototype.DAL.Models;
using OutOfTimePrototype.Dto;
using OutOfTimePrototype.DTO;
using static OutOfTimePrototype.Utilities.ClassUtilities;

namespace OutOfTimePrototype.Services.Interfaces
{
    public interface IClassService
    {
        Task<ClassOperationResult> TryCreateClass(ClassCreateDto ClassCreateDto);
        Task<ClassOperationResult> TryCreateClasses(ClassQueryDto classQueryDto, ClassCreateDto ClassCreateDto);
        Task<ClassOperationResult> TryEditClass(Guid id, ClassEditDto classEditDto, bool nullMode);
        Task<ClassOperationResult> TryEditClasses(ClassQueryDto classQueryDto, ClassEditDto classEditDto, bool nullMode);
        Task<ClassOperationResult> TryDeleteClass(Guid id);
        Task<ClassOperationResult> TryDeleteClasses(ClassQueryDto classQueryDto);
        Task<ClassOperationResult> QueryClasses(ClassQueryDto classQueryDto);
    }
}
