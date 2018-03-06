﻿using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591
// ReSharper disable InconsistentNaming

namespace OpenCvSharp
{
    static partial class NativeMethods
    {
        #region LatendSvmDetector

        [DllImport(DllExtern)]
        public static extern IntPtr objdetect_LatentSvmDetector_new();
        [DllImport(DllExtern)]
        public static extern void objdetect_LatentSvmDetector_delete(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern void objdetect_LatentSvmDetector_clear(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern int objdetect_LatentSvmDetector_empty(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern int objdetect_LatentSvmDetector_load(IntPtr obj,
            IntPtr[] fileNames, int fileNamesLength,
            IntPtr[] classNames, int classNamesLength);
        [DllImport(DllExtern)]
        public static extern void objdetect_LatentSvmDetector_detect(
            IntPtr obj, IntPtr image, IntPtr objectDetections,
            float overlapThreshold, int numThreads);
        [DllImport(DllExtern)]
        public static extern void objdetect_LatentSvmDetector_getClassNames(IntPtr obj, IntPtr outValues);
        [DllImport(DllExtern)]
        public static extern IntPtr objdetect_LatentSvmDetector_getClassCount(IntPtr obj);

        #endregion

        #region CascadeClassfier

        [DllImport(DllExtern)]
        public static extern IntPtr objdetect_CascadeClassifier_new();
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true, ExactSpelling = true)]
        public static extern IntPtr objdetect_CascadeClassifier_newFromFile([MarshalAs(UnmanagedType.LPStr)] string fileName);
        [DllImport(DllExtern)]
        public static extern void objdetect_CascadeClassifier_delete(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern int objdetect_CascadeClassifier_empty(IntPtr obj);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true, ExactSpelling = true)]
        public static extern int objdetect_CascadeClassifier_load(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string fileName);

        [DllImport(DllExtern)]
        public static extern void objdetect_CascadeClassifier_detectMultiScale1(
            IntPtr obj, IntPtr image, IntPtr objects,
            double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize);
        [DllImport(DllExtern)]
        public static extern void objdetect_CascadeClassifier_detectMultiScale2(
            IntPtr obj, IntPtr image, IntPtr objects,
            IntPtr rejectLevels, IntPtr levelWeights,
            double scaleFactor, int minNeighbors, int flags,
            Size minSize, Size maxSize, int outputRejectLevels);

        [DllImport(DllExtern)]
        public static extern int objdetect_CascadeClassifier_isOldFormatCascade(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern Size objdetect_CascadeClassifier_getOriginalWindowSize(IntPtr obj);
        [DllImport(DllExtern)]
        public static extern int objdetect_CascadeClassifier_getFeatureType(IntPtr obj);

        #endregion

        #region HOGDescriptor
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_sizeof();
        [DllImport(DllExtern)]
        public static extern IntPtr objdetect_HOGDescriptor_new1();
        [DllImport(DllExtern)]
        public static extern IntPtr objdetect_HOGDescriptor_new2(Size winSize, Size blockSize, Size blockStride, Size cellSize,
            int nbins, int derivAperture, double winSigma, [MarshalAs(UnmanagedType.I4)] HistogramNormType histogramNormType,
            double l2HysThreshold, int gammaCorrection, int nlevels);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true, ExactSpelling = true)]
        public static extern IntPtr objdetect_HOGDescriptor_new3([MarshalAs(UnmanagedType.LPStr)] string fileName);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_delete(IntPtr self);
        [DllImport(DllExtern)]
        public static extern IntPtr objdetect_HOGDescriptor_getDescriptorSize(IntPtr self);
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_checkDetectorSize(IntPtr self);
        [DllImport(DllExtern)]
        public static extern double objdetect_HOGDescriptor_getWinSigma(IntPtr self);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_setSVMDetector(IntPtr self, IntPtr svmdetector);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true, ExactSpelling = true)]
        public static extern bool objdetect_HOGDescriptor_load(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string filename, [MarshalAs(UnmanagedType.LPStr)] string objname);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true, ExactSpelling = true)]
        public static extern void objdetect_HOGDescriptor_save(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string filename, [MarshalAs(UnmanagedType.LPStr)] string objname);
        
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_compute(
            IntPtr self, IntPtr img, IntPtr descriptors,
                         Size winStride, Size padding, [In] Point[] locations, int locationsLength);

        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_detect1(
            IntPtr self, IntPtr img, IntPtr foundLocations,
            double hitThreshold, Size winStride, Size padding, [In] Point[] searchLocations, int searchLocationsLength);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_detect2(
            IntPtr self, IntPtr img, IntPtr foundLocations, IntPtr weights,
            double hitThreshold, Size winStride, Size padding, [In] Point[] searchLocations, int searchLocationsLength);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_detectMultiScale1(
            IntPtr self, IntPtr img, IntPtr foundLocations,
            double hitThreshold, Size winStride, Size padding, double scale, int groupThreshold);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_detectMultiScale2(
            IntPtr self, IntPtr img, IntPtr foundLocations, IntPtr foundWeights,
            double hitThreshold, Size winStride, Size padding, double scale, int groupThreshold);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_computeGradient(
            IntPtr self, IntPtr img, IntPtr grad, IntPtr angleOfs, Size paddingTL, Size paddingBR);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_detectROI(
            IntPtr obj, IntPtr img,
            Point[] locations, int locationsLength,
            IntPtr foundLocations, IntPtr confidences,
            double hitThreshold, Size winStride, Size padding);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_detectMultiScaleROI(
            IntPtr obj, IntPtr img, IntPtr foundLocations,
            IntPtr roiScales, IntPtr roiLocations, IntPtr roiConfidences,
            double hitThreshold, int groupThreshold);
        [DllImport(DllExtern,  BestFitMapping = false, ThrowOnUnmappableChar = true, ExactSpelling = true)]
        public static extern void objdetect_HOGDescriptor_readALTModel(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string modelfile);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_groupRectangles(IntPtr obj,
            IntPtr rectList, IntPtr weights, int groupThreshold, double eps);


        [DllImport(DllExtern)]
        public static extern Size objdetect_HOGDescriptor_winSize_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern Size objdetect_HOGDescriptor_blockSize_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern Size objdetect_HOGDescriptor_blockStride_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern Size objdetect_HOGDescriptor_cellSize_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_nbins_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_derivAperture_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern double objdetect_HOGDescriptor_winSigma_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_histogramNormType_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern double objdetect_HOGDescriptor_L2HysThreshold_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_gammaCorrection_get(IntPtr self);
        [DllImport(DllExtern)]
        public static extern int objdetect_HOGDescriptor_nlevels_get(IntPtr self);

        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_winSize_set(IntPtr self, Size value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_blockSize_set(IntPtr self, Size value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_blockStride_set(IntPtr self, Size value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_cellSize_set(IntPtr self, Size value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_nbins_set(IntPtr self, int value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_derivAperture_set(IntPtr self, int value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_winSigma_set(IntPtr self, double value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_histogramNormType_set(IntPtr self, int value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_L2HysThreshold_set(IntPtr self, double value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_gammaCorrection_set(IntPtr self, int value);
        [DllImport(DllExtern)]
        public static extern void objdetect_HOGDescriptor_nlevels_set(IntPtr self, int value);
        #endregion

        [DllImport(DllExtern)]
        public static extern void objdetect_groupRectangles1(IntPtr rectList, int groupThreshold, double eps);

        [DllImport(DllExtern)]
        public static extern void objdetect_groupRectangles2(IntPtr rectList, IntPtr weights, int groupThreshold, double eps);

        [DllImport(DllExtern)]
        public static extern void objdetect_groupRectangles3(
            IntPtr rectList, int groupThreshold, double eps, IntPtr weights, IntPtr levelWeights);

        [DllImport(DllExtern)]
        public static extern void objdetect_groupRectangles4(
            IntPtr rectList, IntPtr rejectLevels, IntPtr levelWeights, int groupThreshold, double eps);

        [DllImport(DllExtern)]
        public static extern void objdetect_groupRectangles_meanshift(
            IntPtr rectList, IntPtr foundWeights, IntPtr foundScales, double detectThreshold, Size winDetSize);
    }
}