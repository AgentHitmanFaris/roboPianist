# Bolt Journal

## 2024-05-22 - Piano Optimization & Unity Upgrade
**Learning:** Cached `Renderer.material` to avoid property access overhead in hot loops. Hoisted loop-invariant color calculations.
**Action:** When optimizing loop performance in Unity, always check for property accessors that might hide expensive operations (like material instantiation or internal checks).

**Learning:** Converted `MySmoothCamera.js` (UnityScript) to C# to support modern Unity versions.
**Action:** Preserved the GUID from the `.js.meta` file to the new `.cs.meta` file. This *might* preserve scene references if Unity's importer handles the type change gracefully, but users should verify "Missing Script" errors in the scene.
