# Nonlinear-NewtonMethod
solving a nonlinear problem with newton method

NEWTON'S METHOD (equations are givenin LaTeX code format)

In calculus, Newton's method is an iterative method for finding the roots of a differentiable function f, which are solutions to the 
equation f (x) = 0. More specifically, in optimization, Newton's method is applied to the derivative f ′ of a twice-differentiable 
function f to find the roots of the derivative (solutions to f ′(x) = 0), also known as the stationary points of f. These solutions 
may be minima, maxima, or saddle points.

In the one-dimensional problem, Newton's method attempts to find the roots of f ′ by constructing a sequence xn from an initial guess 
x0 that converges towards some value x* satisfying f ′(x*) = 0. This x* is a stationary point of f.

The second-order Taylor expansion fT (x) of a function f around xn is
{\displaystyle f_{T}(x)=f_{T}(x_{n}+\Delta x)\approx f(x_{n})+f'(x_{n})\Delta x+{\frac {1}{2}}f''(x_{n})\Delta x^{2}.}

Ideally, we want to pick a Δx such that xn + Δx is a stationary point of f. Using this Taylor expansion as an approximation, we can at 
least solve for the Δx corresponding to the root of the expansion's derivative:

{\displaystyle \displaystyle 0={\frac {\rm {d}}{\rm {d\Delta x}}}\left(f(x_{n})+f'(x_{n})\Delta x+{\frac {1}{2}}f''(x_{n})\Delta x^{2}\right)=f'(x_{n})+f''(x_{n})\Delta x}

{\displaystyle \Delta x=-{\frac {f'(x_{n})}{f''(x_{n})}}.} 

Provided the Taylor approximation is fairly accurate, then incrementing by the above Δx should yield a point fairly close to an actual 
stationary point of f. This point, xn+1 = xn + Δx = xn − f ′(xn) / f ″(xn), we define to be the n + 1th guess in Newton's method; as n 
tends toward infinity, xn should approach a stationary point x* of the actual function f. Indeed, it is proven that if f is a 
twice-differentiable function and other technical conditions are satisfied, the sequence x1, x2, … will converge to a point x* satisfying 
f ′(x*) = 0.
