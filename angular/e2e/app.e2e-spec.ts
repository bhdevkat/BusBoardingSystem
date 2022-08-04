import { BusBoardingSystemTemplatePage } from './app.po';

describe('BusBoardingSystem App', function() {
  let page: BusBoardingSystemTemplatePage;

  beforeEach(() => {
    page = new BusBoardingSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
