/** @type {import('tailwindcss').Config} */
module.exports = {
	content: ['./**/*.{razor, html}'],
	theme: {
		extend: {
			minHeight: {
				"100vh": "100vh",
			},
			fontFamily: {
				"ibm-mono": ['IBM Plex Mono', 'monospace'],
			},
		},
		screens: {
			'2xl': { 'max': '1535px' },
			'xl': { 'max': '1279px' },
			'lg': { 'max': '1023px' },
			'md': { 'max': '767px' },
			'sm': { 'max': '639px' },
		},
	},
	plugins: [],
}

