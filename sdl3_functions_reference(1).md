# SDL3 Functions Reference Manual

A comprehensive, categorized reference guide for **SDL3** core functions, detailing complete function signatures, C data types, and parameters.

---

## 1. Application Lifecycle, Initialization & Errors

### SDL_Init
Initializes the specified SDL subsystems.
```c
bool SDL_Init(SDL_InitFlags flags);
```
*   `flags`: Subsystem initialization flags bitmask (e.g., `SDL_INIT_VIDEO`, `SDL_INIT_AUDIO`, `SDL_INIT_GAMEPAD`).
*   **Returns**: `true` on success, `false` on failure.

### SDL_Quit
Cleans up and shuts down all initialized SDL subsystems.
```c
void SDL_Quit(void);
```

### SDL_InitSubSystem
Initializes specific SDL subsystems dynamically after the main initialization step.
```c
bool SDL_InitSubSystem(SDL_InitFlags flags);
```
*   `flags`: Subsystem flags to initialize.
*   **Returns**: `true` on success, `false` on failure.

### SDL_QuitSubSystem
Shuts down specific SDL subsystems while leaving others active.
```c
void SDL_QuitSubSystem(SDL_InitFlags flags);
```
*   `flags`: Subsystem flags to shut down.

### SDL_GetError
Retrieves a human-readable string explaining the last internal SDL error that occurred.
```c
const char* SDL_GetError(void);
```
*   **Returns**: A pointer to an internal error string, or an empty string if no error has occurred.

### SDL_ClearError
Clears any active error message string currently stored internally by SDL.
```c
bool SDL_ClearError(void);
```
*   **Returns**: Always returns `true`.

---

## 2. Video & Window Management

### SDL_CreateWindow
Creates a window with the specified title, dimensions, and creation configuration flags.
```c
SDL_Window* SDL_CreateWindow(const char* title, int w, int h, SDL_WindowFlags flags);
```
*   `title`: The UTF-8 title string displayed at the top of the window frame.
*   `w`: The desired target width of the window context area in screen coordinates.
*   `h`: The desired target height of the window context area in screen coordinates.
*   `flags`: Operational flags bitmask (e.g., `SDL_WINDOW_RESIZABLE`, `SDL_WINDOW_FULLSCREEN`, `SDL_WINDOW_HIDDEN`).
*   **Returns**: A pointer to the newly allocated `SDL_Window` structure, or `NULL` on failure.

### SDL_DestroyWindow
Destroys a window and releases all resources associated with it.
```c
void SDL_DestroyWindow(SDL_Window* window);
```
*   `window`: The pointer to the valid `SDL_Window` context that needs to be destroyed.

### SDL_ShowWindow
Makes a hidden window visible on the target display environment.
```c
bool SDL_ShowWindow(SDL_Window* window);
```
*   `window`: The window context pointer to show.
*   **Returns**: `true` on success, `false` on failure.

### SDL_HideWindow
Hides an active window without destroying its state context.
```c
bool SDL_HideWindow(SDL_Window* window);
```
*   `window`: The window context pointer to hide.
*   **Returns**: `true` on success, `false` on failure.

### SDL_RaiseWindow
Raises a window above other windows and requests active user focus for it.
```c
bool SDL_RaiseWindow(SDL_Window* window);
```
*   `window`: The target window context pointer to raise.
*   **Returns**: `true` on success, `false` on failure.

### SDL_MaximizeWindow
Maximizes a window to occupy the largest possible bounds of the display.
```c
bool SDL_MaximizeWindow(SDL_Window* window);
```
*   `window`: The window context pointer to maximize.
*   **Returns**: `true` on success, `false` on failure.

### SDL_MinimizeWindow
Minimizes a window to its native operating system icon/taskbar element.
```c
bool SDL_MinimizeWindow(SDL_Window* window);
```
*   `window`: The window context pointer to minimize.
*   **Returns**: `true` on success, `false` on failure.

### SDL_RestoreWindow
Restores a minimized or maximized window back to its normal state sizes.
```c
bool SDL_RestoreWindow(SDL_Window* window);
```
*   `window`: The target window context pointer to restore.
*   **Returns**: `true` on success, `false` on failure.

### SDL_SetWindowSize
Updates the physical size dimensions of a window workspace area directly.
```c
bool SDL_SetWindowSize(SDL_Window* window, int w, int h);
```
*   `window`: The target window pointer context.
*   `w`: The new target width integer value.
*   `h`: The new target height integer value.
*   **Returns**: `true` on success, `false` on failure.

### SDL_GetWindowSize
Retrieves the actual dimensions of a window context in screen coordinate units.
```c
bool SDL_GetWindowSize(SDL_Window* window, int* w, int* h);
```
*   `window`: The target window context pointer to query.
*   `w`: A valid pointer to an integer that receives the width dimension value.
*   `h`: A valid pointer to an integer that receives the height dimension value.
*   **Returns**: `true` on success, `false` on failure.

### SDL_SetWindowPosition
Moves the window container component to a specific absolute screen position coordinate.
```c
bool SDL_SetWindowPosition(SDL_Window* window, int x, int y);
```
*   `window`: The window context target pointer.
*   `x`: The absolute X coordinate location on the target display grid.
*   `y`: The absolute Y coordinate location on the target display grid.
*   **Returns**: `true` on success, `false` on failure.

### SDL_GetWindowPosition
Retrieves the absolute screen position coordinates of a target window.
```c
bool SDL_GetWindowPosition(SDL_Window* window, int* x, int* y);
```
*   `window`: The window context target pointer to query.
*   `x`: A valid pointer to an integer that receives the top-left X coordinate location.
*   `y`: A valid pointer to an integer that receives the top-left Y coordinate location.
*   **Returns**: `true` on success, `false` on failure.

### SDL_SetWindowTitle
Updates the caption text string displayed on the frame of a window.
```c
bool SDL_SetWindowTitle(SDL_Window* window, const char* title);
```
*   `window`: The window context target pointer.
*   `title`: A null-terminated UTF-8 string to assign as the new caption title.
*   **Returns**: `true` on success, `false` on failure.

### SDL_GetWindowTitle
Gets the active title text string assigned to a window.
```c
const char* SDL_GetWindowTitle(SDL_Window* window);
```
*   `window`: The window context target pointer to query.
*   **Returns**: A pointer to a UTF-8 encoded string title, or `NULL` if no window title is found.

---

## 3. 2D Rendering Engine

### SDL_CreateRenderer
Creates a hardware-accelerated standard 2D rendering graphics pipeline context for a target window.
```c
SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, const char* name);
```
*   `window`: The window frame context where the rendering canvas pipeline will be displayed.
*   `name`: The specialized backend name string (e.g., `"direct3d12"`, `"vulkan"`, `"opengl"`). Set to `NULL` to default to the optimal rendering backend.
*   **Returns**: A pointer to a newly created `SDL_Renderer` context block, or `NULL` on error.

### SDL_DestroyRenderer
Disables a rendering context pipeline and frees all backing driver data objects.
```c
void SDL_DestroyRenderer(SDL_Renderer* renderer);
```
*   `renderer`: The pointer to a valid `SDL_Renderer` context that needs to be destroyed.

### SDL_SetRenderDrawColor
Sets the universal color components utilized by the active drawing pipeline commands.
```c
bool SDL_SetRenderDrawColor(SDL_Renderer* renderer, Uint8 r, Uint8 g, Uint8 b, Uint8 a);
```
*   `renderer`: The target rendering pipeline context pointer.
*   `r`: Red color channel component intensity value (0-255).
*   `g`: Green color channel component intensity value (0-255).
*   `b`: Blue color channel component intensity value (0-255).
*   `a`: Alpha color transparency channel channel component intensity value (0-255).
*   **Returns**: `true` on success, `false` on failure.

### SDL_RenderClear
Clears the active rendering destination buffer layout using the currently configured draw color.
```c
bool SDL_RenderClear(SDL_Renderer* renderer);
```
*   `renderer`: The target rendering pipeline context pointer.
*   **Returns**: `true` on success, `false` on failure.

### SDL_RenderPresent
Flushes pending drawing commands to the graphics processing adapter and flips screen framebuffers to show changes.
```c
bool SDL_RenderPresent(SDL_Renderer* renderer);
```
*   `renderer`: The target rendering pipeline context pointer.
*   **Returns**: `true` on success, `false` on failure.

### SDL_RenderLine
Draws a basic line segment between two target coordinate locations on the render viewport.
```c
bool SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);
```
*   `renderer`: The target rendering pipeline context pointer.
*   `x1`: The X coordinate space index of the first vertex.
*   `y1`: The Y coordinate space index of the first vertex.
*   `x2`: The X coordinate space index of the second vertex.
*   `y2`: The Y coordinate space index of the second vertex.
*   **Returns**: `true` on success, `false` on failure.

### SDL_RenderRect
Draws the outline frame boundaries of a rectangle workspace utilizing floating-point parameters.
```c
bool SDL_RenderRect(SDL_Renderer* renderer, const SDL_FRect* rect);
```
*   `renderer`: The target rendering pipeline context pointer.
*   `rect`: A pointer to an `SDL_FRect` structural coordinate layout layout defining the canvas borders.
*   **Returns**: `true` on success, `false` on failure.

### SDL_RenderFillRect
Fills the interior bounds of a rectangle block workspace canvas with the configured draw color.
```c
bool SDL_RenderFillRect(SDL_Renderer* renderer, const SDL_FRect* rect);
```
*   `renderer`: The target rendering pipeline context pointer.
*   `rect`: A pointer to an `SDL_FRect` structure defining the workspace bounds.
*   **Returns**: `true` on success, `false` on failure.

---

## 4. Surfaces & Textures

### SDL_CreateSurface
Allocates a blank software memory surface mapping layout matching pixel-format standards.
```c
SDL_Surface* SDL_CreateSurface(int width, int height, SDL_PixelFormat format);
```
*   `width`: The software surface matrix horizontal width.
*   `height`: The software surface matrix vertical height.
*   `format`: An enum indicating the target pixel format sequence layout to apply.
*   **Returns**: A pointer to a newly allocated `SDL_Surface` structure, or `NULL` on error.

### SDL_DestroySurface
Frees a software surface memory map block layout and context structures cleanly.
```c
void SDL_DestroySurface(SDL_Surface* surface);
```
*   `surface`: The pointer to a valid `SDL_Surface` context data layout block.

### SDL_LoadBMP
Loads a basic standard Windows Bitmap (.BMP) graphic file directly into software memory space.
```c
SDL_Surface* SDL_LoadBMP(const char* file);
```
*   `file`: The system disk path string highlighting the target `.bmp` source file location.
*   **Returns**: A pointer to an allocated software `SDL_Surface` containing pixel information, or `NULL` on failure.

### SDL_CreateTextureFromSurface
Converts a software memory `SDL_Surface` map component into a hardware GPU `SDL_Texture` pipeline component.
```c
SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);
```
*   `renderer`: The destination hardware graphics acceleration renderer target workspace.
*   `surface`: The source software pixel data buffer surface memory asset pointer.
*   **Returns**: A pointer to the newly allocated GPU texture resource context, or `NULL` on failure.

### SDL_DestroyTexture
Unloads a GPU texture graphics resource map layout item and context parameters cleanly.
```c
void SDL_DestroyTexture(SDL_Texture* texture);
```
*   `texture`: The pointer to a valid GPU texture tracking resource context that needs to be destroyed.

### SDL_RenderTexture
Blits or draws a hardware-backed GPU texture asset into the current viewport layout frame space.
```c
bool SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, const SDL_FRect* srcrect, const SDL_FRect* dstrect);
```
*   `renderer`: The active rendering destination workspace.
*   `texture`: The target graphics source GPU texture object pointer.
*   `srcrect`: A pointer to an `SDL_FRect` structure indicating the source crop sub-boundary (or `NULL` for the entire asset).
*   `dstrect`: A pointer to an `SDL_FRect` structure tracking the target placement location constraints (or `NULL` to scale across the whole buffer view).
*   **Returns**: `true` on success, `false` on failure.

---

## 5. Event Handling & Input Subsystem

### SDL_PollEvent
Checks the system queue frame loop for any waiting platform input engine events.
```c
bool SDL_PollEvent(SDL_Event* event);
```
*   `event`: A pointer to an empty `SDL_Event` union block structure that gets filled with data if an event is waiting.
*   **Returns**: `true` if an event was removed from the active queue buffer, `false` if the event queue is currently empty.

### SDL_WaitEvent
Blocks execution inside the active application process runtime until an event is received.
```c
bool SDL_WaitEvent(SDL_Event* event);
```
*   `event`: A pointer to an empty `SDL_Event` union tracking structure that receives the event info.
*   **Returns**: `true` on successfully capturing an event object, `false` if an unrecoverable system exception occurred while waiting.

### SDL_GetKeyboardState
Retrieves a snapshot lookup map array containing the current state elements of keys on the keyboard.
```c
const bool* SDL_GetKeyboardState(int* numkeys);
```
*   `numkeys`: An optional pointer to an integer variable that receives the absolute length size count of the returned lookup boolean array.
*   **Returns**: A pointer to an array of booleans where index entries corresponding to `SDL_Scancode` evaluate to `true` when pressed down.

### SDL_GetMouseState
Queries the active workspace desktop environment context to track the mouse cursor location index.
```c
SDL_MouseButtonFlags SDL_GetMouseState(float* x, float* y);
```
*   `x`: A valid pointer to a float variable receiving the absolute relative X position coordinate of the cursor pointer.
*   `y`: A valid pointer to a float variable receiving the absolute relative Y position coordinate of the cursor pointer.
*   **Returns**: A bitmask structure collection field detailing the active mouse button clicks (e.g., `SDL_BUTTON_MASK_LEFT`).

---

## 6. Audio Streams & Systems

### SDL_OpenAudioDevice
Opens a physical hardware audio device tracking context interface block for streaming sound data waves.
```c
SDL_AudioDeviceID SDL_OpenAudioDevice(SDL_AudioDeviceID devid, const SDL_AudioSpec* spec);
```
*   `devid`: The specialized target hardware sound adapter ID index. Use `SDL_AUDIO_DEVICE_DEFAULT` to default to standard platform outputs.
*   `spec`: A pointer to an `SDL_AudioSpec` structural setup layout configuration block defining sample frequency channels.
*   **Returns**: A valid `SDL_AudioDeviceID` channel reference key index on success, or `0` if opening the device layout failed.

### SDL_CloseAudioDevice
Shuts down a physical hardware audio device tracking channel pipeline and cleans parameters cleanly.
```c
void SDL_CloseAudioDevice(SDL_AudioDeviceID devid);
```
*   `devid`: The valid open audio tracking identifier key index that needs to be dismantled.

### SDL_CreateAudioStream
Allocates a real-time hardware dynamic sound mixing audio stream handler translation converter pipe interface.
```c
SDL_AudioStream* SDL_CreateAudioStream(const SDL_AudioSpec* src_spec, const SDL_AudioSpec* dst_spec);
```
*   `src_spec`: The input data buffer audio wave formatting template specification block.
*   `dst_spec`: The output target target driver audio translation device formatting specification block.
*   **Returns**: A pointer tracking the newly established conversion pipeline `SDL_AudioStream`, or `NULL` on failure.

### SDL_DestroyAudioStream
Cleans up and releases a streaming audio data pipeline channel tracking buffer block handler.
```c
void SDL_DestroyAudioStream(SDL_AudioStream* stream);
```
*   `stream`: The dynamic reference pipeline pointer workspace block layout to dismantle.

---

## 7. Threads & Platform Concurrency

### SDL_CreateThread
Creates a new operating system native concurrent execution thread environment block.
```c
SDL_Thread* SDL_CreateThread(SDL_ThreadFunction fn, const char* name, void* data);
```
*   `fn`: The actual custom C callback worker function pointer execution address that handles work processing logic routines.
*   `name`: A debugging reference thread descriptor text title string tracking identity.
*   `data`: A generic data void pointer address context package passed through into the callback handler framework.
*   **Returns**: A pointer mapping the underlying active concurrent context tracking block element `SDL_Thread`, or `NULL` on thread generation exceptions.

### SDL_WaitThread
Blocks the calling process pipeline runtime context until a targeted active thread completes its routine executions.
```c
void SDL_WaitThread(SDL_Thread* thread, int* status);
```
*   `thread`: The active valid target tracking thread structural workspace handler context block address.
*   `status`: An optional pointer to an integer variables container receiving the processing exit status code output.

---

## 8. System Timers & Time Management

### SDL_GetTicks
Retrieves the total number of milliseconds that have elapsed since the primary SDL initialization sequence sequence hook step.
```c
Uint64 SDL_GetTicks(void);
```
*   **Returns**: A 64-bit unsigned integer value indicating elapsed processing runtime milliseconds tracking indices.

### SDL_Delay
Suspends application processing thread execution routines for a specified period of duration time.
```c
void SDL_Delay(Uint32 ms);
```
*   `ms`: The target integer delay duration length quantified in absolute millisecond interval steps.